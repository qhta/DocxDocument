using Qhta.Collections;

namespace DocumentModel.EnumTypesOpenXmlConverter;

public static class EnumTypeOpenXmlConverterExtensions
{
  public static DocumentModel.Wordprocessing.LineStyle ToLineType
    (this DocumentFormat.OpenXml.Wordprocessing.BorderValues lineStyle)
  {
    if (_borderValuesMap.TryGetValue2(lineStyle, out var result))
    {
      return result;
    }
    return DocumentModel.Wordprocessing.LineStyle.None;
  }

  public static DocumentFormat.OpenXml.Wordprocessing.BorderValues ToBorderValues
    (this DocumentModel.Wordprocessing.LineStyle lineStyle)
  {
    if (_borderValuesMap.TryGetValue1(lineStyle, out var result))
    {
      return result;
    }
    return DocumentFormat.OpenXml.Wordprocessing.BorderValues.None;
  }

  private static BiDiDictionary<DocumentFormat.OpenXml.Wordprocessing.BorderValues, DocumentModel.Wordprocessing.LineStyle> _borderValuesMap=
    new BiDiDictionary<DocumentFormat.OpenXml.Wordprocessing.BorderValues, DocumentModel.Wordprocessing.LineStyle>()
    {
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.None, DocumentModel.Wordprocessing.LineStyle.None },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.Single, DocumentModel.Wordprocessing.LineStyle.Single },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.Dotted, DocumentModel.Wordprocessing.LineStyle.Dot },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.DashSmallGap, DocumentModel.Wordprocessing.LineStyle.DashSmallGap },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.Dashed, DocumentModel.Wordprocessing.LineStyle.DashLargeGap },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.DotDash, DocumentModel.Wordprocessing.LineStyle.DashDot },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.DotDotDash, DocumentModel.Wordprocessing.LineStyle.DashDotDot },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.Double, DocumentModel.Wordprocessing.LineStyle.Double },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.Triple, DocumentModel.Wordprocessing.LineStyle.Triple },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickSmallGap, DocumentModel.Wordprocessing.LineStyle.ThinThickSmallGap },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThickThinSmallGap, DocumentModel.Wordprocessing.LineStyle.ThickThinSmallGap },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickThinSmallGap, DocumentModel.Wordprocessing.LineStyle.ThinThickThinSmallGap },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickMediumGap, DocumentModel.Wordprocessing.LineStyle.ThinThickMedGap },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThickThinMediumGap, DocumentModel.Wordprocessing.LineStyle.ThickThinMedGap },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickThinMediumGap, DocumentModel.Wordprocessing.LineStyle.ThinThickThinMedGap },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickLargeGap, DocumentModel.Wordprocessing.LineStyle.ThinThickLargeGap },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThickThinLargeGap, DocumentModel.Wordprocessing.LineStyle.ThickThinLargeGap },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickThinLargeGap, DocumentModel.Wordprocessing.LineStyle.ThinThickThinLargeGap },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.Wave, DocumentModel.Wordprocessing.LineStyle.SingleWavy },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.DoubleWave, DocumentModel.Wordprocessing.LineStyle.DoubleWavy },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.DashDotStroked, DocumentModel.Wordprocessing.LineStyle.DashDotStroked },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThreeDEmboss, DocumentModel.Wordprocessing.LineStyle.Emboss3D },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThreeDEngrave, DocumentModel.Wordprocessing.LineStyle.Engrave3D },
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.Outset, DocumentModel.Wordprocessing.LineStyle.Outset},
      { DocumentFormat.OpenXml.Wordprocessing.BorderValues.Inset, DocumentModel.Wordprocessing.LineStyle.Inset},


    };
  }