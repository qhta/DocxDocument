using DocumentFormat.OpenXml.Wordprocessing;

namespace DocxToLatex.Converter.XLDocument.XLStyles;

public static class PropertyAssignHelper
{
  public static bool? TryAssign(OnOffType srcProp, bool? destProp)
  {
    if (srcProp == null)
    {
      return destProp;
    }

    if (srcProp?.Val is null)
    {
      return true;
    }

    if (srcProp?.Val.HasValue == true)
    {
      destProp = srcProp.Val.Value;
    }

    return destProp;
  }

  public static DocxDocument.Model.Underline? TryAssign(DocumentFormat.OpenXml.Wordprocessing.Underline srcProp, DocxDocument.Model.Underline? destProp)
  {
    if (srcProp == null)
    {
      return destProp;
    }

    if (srcProp?.Val?.HasValue == true)
    {
      switch (srcProp.Val.Value)
      {
        case UnderlineValues.None:
          return DocxDocument.Model.Underline.None;

        case UnderlineValues.Single:
          return DocxDocument.Model.Underline.Single;

        case UnderlineValues.Double:
          return DocxDocument.Model.Underline.Double;

        case UnderlineValues.Dotted:
        case UnderlineValues.DotDash:
        case UnderlineValues.DotDotDash:
        case UnderlineValues.DottedHeavy:
          return DocxDocument.Model.Underline.Dotted;

        case UnderlineValues.Dash:
        case UnderlineValues.DashDotHeavy:
        case UnderlineValues.DashDotDotHeavy:
        case UnderlineValues.DashedHeavy:
          return DocxDocument.Model.Underline.Dash;

        case UnderlineValues.Wave:
        case UnderlineValues.WavyDouble:
        case UnderlineValues.WavyHeavy:
          return DocxDocument.Model.Underline.Wavy;

        default:
          return DocxDocument.Model.Underline.Single;
      }
    }
    return destProp;
  }

  public static DocxDocument.Model.Justification? TryAssign(DocumentFormat.OpenXml.Wordprocessing.Justification srcProp, DocxDocument.Model.Justification? destProp)
  {
    if (srcProp == null)
    {
      return destProp;
    }

    if (srcProp?.Val?.HasValue == true)
    {
      switch (srcProp.Val.Value)
      {
        case JustificationValues.Left:
          return DocxDocument.Model.Justification.Left;

        case JustificationValues.Center:
          return DocxDocument.Model.Justification.Center;

        case JustificationValues.Right:
          return DocxDocument.Model.Justification.Right;

        case JustificationValues.Both:
          return DocxDocument.Model.Justification.Justified;

        default:
          break;
      }
    }

    return destProp;
  }
}