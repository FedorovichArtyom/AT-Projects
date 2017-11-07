﻿using System;

namespace task_DEV_13
{
  // Defines an appropriate group of developers for the custom client.
  // Input: from args format - "'price' 'efficiency' 'criterion'".
  public class EntryPoint
  {
    static void Main(string[] args)
    {
      // Get program parameters.
      ConsoleArgsValidator validator = new ConsoleArgsValidator(args);
      decimal price = 0m;
      int efficiency = 0;
      DevGroupCreationCriterion criterion = DevGroupCreationCriterion.MaxEfficiency;
      
      try
      {
        price = validator.GetValidPrice();
        efficiency = validator.GetValidEfficiency();
        criterion = validator.GetValidCriterion();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }

      // Choose the criterion and create appropriate group.
      DevGroupProvider groupProvider = new DevGroupProvider(price, efficiency);
      DevGroup mostAppropriateGroup = new DevGroup();
      switch (criterion)
      { 
        case DevGroupCreationCriterion.MaxEfficiency:
          mostAppropriateGroup = groupProvider.GetDevGroupWithMaxEfficiencyForPrice();
          break;
        case DevGroupCreationCriterion.MinCost:
          mostAppropriateGroup = groupProvider.GetDevGroupWithMinPriceForCustomEfficiency();
          break;
        case DevGroupCreationCriterion.MinJuniorDevsAmount:
          mostAppropriateGroup = groupProvider.GetDevGroupWithMinNonJuniorsForEfficiency();
          break;
      }

      Console.WriteLine(AssemblyInfo.RESULT_MESSAGE,
        mostAppropriateGroup.Constituents.JuniorAmount,
        mostAppropriateGroup.Constituents.MiddleAmount,
        mostAppropriateGroup.Constituents.SeniorAmount,
        mostAppropriateGroup.Constituents.LeadAmount);
    }
  }
}
