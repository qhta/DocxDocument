

using System.Diagnostics;

using DocumentModel.OpenXml;

using DX = DocumentFormat.OpenXml;
using DXW = DocumentFormat.OpenXml.Wordprocessing;
using DXO10W = DocumentFormat.OpenXml.Office2010.Word;
using DXO13W = DocumentFormat.OpenXml.Office2013.Word;
using DXM = DocumentFormat.OpenXml.Math;
using DXD = DocumentFormat.OpenXml.Drawing;
using DXVS = DocumentFormat.OpenXml.Vml.Spreadsheet;

namespace DocumentModel.BaseConverters.Test;

public static class BooleanOpenXmlConverterTest
{
  public static Type[] SupportedTypes { get; } =
  [
    typeof(DXW.CarriageReturn), //DXW.EmptyType
    typeof(DXD.MasterColorMapping), //DXD.EmptyType
    typeof(DXO10W.NoFillEmpty), //DXO10W.EmptyType
    typeof(DX.OnOffValue),
    typeof(DXW.OnOffOnlyValues),
    typeof(DX.EnumValue<DXW.OnOffOnlyValues>),
    typeof(DXW.Active), //DXW.OnOffType
    typeof(DXO10W.ConflictMode), //DXO10W.OnOffType
    typeof(DXO13W.DefaultCollapsed), //DXO13W.OnOffType
    typeof(DXM.Alignment), //DXM.OnOffType
    typeof(DXW.AutoRedefine), //DXW.OnOffOnlyType
    typeof(DXO10W.OnOffValues),
    typeof(DX.EnumValue<DXO10W.OnOffValues>),
    typeof(DX.BooleanValue),
    typeof(DXM.BooleanValues),
    typeof(DX.TrueFalseValue),
    typeof(DX.TrueFalseBlankValue),
    typeof(DX.EnumValue<DXM.BooleanValues>),
    typeof(DXVS.Visible),
  ];

  public static bool Run()
  {
    bool testResult = true;

    foreach (var type in SupportedTypes)
    {
      Console.Write($"TestBoolOpenXmlConversion with {type.Name} ");
      if (!TestBoolOpenXmlConversion(type))
      {
        Console.WriteLine("failed.");
        testResult = false;
      }
      else
        Console.WriteLine("passed.");
    }

    return testResult;
  }

  public static bool TestBoolOpenXmlConversion(Type openXmlType)
  {
    if (openXmlType.Name.StartsWith("TrueFalse"))
      Debug.Assert(true);
    bool trueInput = true;
    var trueOpenXml = BooleanOpenXmlConverter.ConvertToOpenXml(trueInput, openXmlType);
    var trueOutput = BooleanOpenXmlConverter.ConvertFromOpenXml(trueOpenXml);
    if (trueOutput is not bool trueBool || trueBool != true)
      return false;
    bool falseInput = false;
    var falseOpenXml = BooleanOpenXmlConverter.ConvertToOpenXml(falseInput, openXmlType);
    var falseOutput = BooleanOpenXmlConverter.ConvertFromOpenXml(falseOpenXml);
    if (openXmlType.BaseType?.Name == "EmptyType")
    {
      // Special case: EmptyType converts false to null
      if (falseOutput is not null)
        return false;
    }
    else
    if (falseOutput is not bool falseBool || falseBool != false)
      return false;

    bool? nullInput = null;
    var nullOpenXml = BooleanOpenXmlConverter.ConvertToOpenXml(nullInput, openXmlType);
    var nullOutput = BooleanOpenXmlConverter.ConvertFromOpenXml(nullOpenXml);
    if (nullOutput is not null)
      return false;
    return true;
  }


}
