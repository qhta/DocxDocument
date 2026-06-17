using DocumentFormat.OpenXml.Office.CoverPageProps;

namespace DocumentModel.InOpenXml.Test;

internal class Program
{
  public static void Main(string[] args)
  {
    // Ensure Unicode characters display correctly
    Console.OutputEncoding = System.Text.Encoding.UTF8;

    Console.WriteLine("╔═════════════════════════════════════════════╗");
    Console.WriteLine("║   DocumentModel InOpenXml Test Suite        ║");
    Console.WriteLine("╚═════════════════════════════════════════════╝");
    Console.WriteLine();
    if (!Exec(new ElementCollectionTest())) return;
    if (!Exec(new CorePropertiesTest())) return;
    if (!Exec(new ContentPropertiesTest())) return;
    if (!Exec(new StatisticPropertiesTest())) return;
    if (!Exec(new BuiltInPropertiesTest())) return;
    if (!Exec(new CustomPropertiesTest())) return;
    if (!Exec(new DocumentPropertiesTest())) return;

    //if (!Exec(new DocumentSettingsTest())) return;
    //if (!Exec(new RsidsTest())) return;
    //if (!Exec(new DocumentVariablesTestClass())) return;
    if (!Exec(new FontTableTestClass())) return;
    //if (!Exec(new LatentStylesTest())) return;
    //if (!Exec(new StyleDefinitionsTest())) return;
    //if (!Exec(new BaseRunPropertiesTest())) return;
    //if (!Exec(new StyleDocDefaultsRunPropertiesTest())) return;
    //if (!Exec(new BaseParagraphPropertiesTest())) return;
    //if (!Exec(new StyleDocDefaultsParagraphPropertiesTest())) return;
    //if (!Exec(new AbstractNumberingsTest())) return;
    //if (!Exec(new NumberingInstancesTest())) return;
    //if (!Exec(new BaseSectionPropertiesTest())) return;
    //if (!Exec(new BaseTableCellPropertiesTest())) return;
    //if (!Exec(new BaseTableRowPropertiesTest())) return;
    //if (!Exec(new BaseTablePropertiesTest())) return;
    //if (!Exec(new ColorTypesTest())) return;
    //if (!Exec(new ThemeTest())) return;
    //if (!new Exec()new Test())) return;

    Console.WriteLine("All tests passed.");
  }

  /// <summary>
  ///new ()s the specified test method and reports the result to the console.
  /// </summary>
  /// <param name="test"></param>
  /// <returns></returns>
  private static bool Exec(_AbstractTestClass test)
  {
    if (!test.Run())
    {
      Console.WriteLine("\nSome tests failed.");
      return false;
    }
    Console.WriteLine();
    Console.WriteLine("═══════════════════════════════════════════════════════════");
    Console.WriteLine();
    return true;
  }
}

