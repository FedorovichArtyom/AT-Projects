﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Управление общими сведениями о сборке осуществляется с помощью 
// набора атрибутов. Измените значения этих атрибутов, чтобы изменить сведения,
// связанные со сборкой.
[assembly: AssemblyTitle("task_DEV-9")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("task_DEV-9")]
[assembly: AssemblyCopyright("Copyright ©  2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Параметр ComVisible со значением FALSE делает типы в сборке невидимыми 
// для COM-компонентов.  Если требуется обратиться к типу в этой сборке через 
// COM, задайте атрибуту ComVisible значение TRUE для этого типа.
[assembly: ComVisible(false)]

// Следующий GUID служит для идентификации библиотеки типов, если этот проект будет видимым для COM
[assembly: Guid("4a19d02e-690d-43d7-92bd-fa7e9e11bd61")]

// Сведения о версии сборки состоят из следующих четырех значений:
//
//      Основной номер версии
//      Дополнительный номер версии 
//      Номер построения
//      Редакция
//
// Можно задать все значения или принять номер построения и номер редакции по умолчанию, 
// используя "*", как показано ниже:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

public class AssemblyInfo
{
  public const string beforeSwapOperationMessage = "Changed string: {0}, changing string: {1}";
  public const string afterSwapOperationMessage = "String after swap operation: {0}";
  public const string notValidDataAmountMessage = "The amount of inputed strings is incorrect. There should be 2 strings.";
  public const string emptyFileNameMessage = "Can't open the file. Enter filename.";
  public const string notValidFileTypeMessage = "Incorrect filetype. It should be .txt format.";
  public const string cantOpenFileMessage = "Can't open the file. Check the existence of this file in the project's root directory";
  public const string ioStreamConflictMessage = "Can't read data from the file.";
}
