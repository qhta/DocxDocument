using DocumentFormat.OpenXml.Wordprocessing;

namespace DocxToLatex.Converter.XLDocument.XLStyles;

public interface IXLPropertiesFiller
{
  void FillParagraphProperties(DocxDocument.Model.ParagraphProperties parProps, StyleParagraphProperties props);
  void FillParagraphProperties(DocxDocument.Model.ParagraphProperties parProps, ParagraphProperties props);
  void FillRunProperties(DocxDocument.Model.RunProperties parProps, StyleRunProperties props);
  void FillRunProperties(DocxDocument.Model.RunProperties parProps, DocumentFormat.OpenXml.Wordprocessing.RunProperties props);
}

public class XLPropertiesFiller : IXLPropertiesFiller
{
  public void FillParagraphProperties(DocxDocument.Model.ParagraphProperties parProps, StyleParagraphProperties props)
  {
    parProps.Justification = PropertyAssignHelper.TryAssign(props.Justification, parProps.Justification);
  }

  public void FillParagraphProperties(DocxDocument.Model.ParagraphProperties parProps, ParagraphProperties props)
  {
    parProps.Justification = PropertyAssignHelper.TryAssign(props.Justification, parProps.Justification);
  }

  public void FillRunProperties(DocxDocument.Model.RunProperties parProps, StyleRunProperties props)
  {
    parProps.Bold = PropertyAssignHelper.TryAssign(props.Bold, parProps.Bold);
    parProps.AllCaps = PropertyAssignHelper.TryAssign(props.Caps, parProps.AllCaps);
    parProps.DoubleStrikeThrough = PropertyAssignHelper.TryAssign(props.DoubleStrike, parProps.DoubleStrikeThrough);
    parProps.Italic = PropertyAssignHelper.TryAssign(props.Italic, parProps.Italic);
    parProps.Underline = PropertyAssignHelper.TryAssign(props.Underline, parProps.Underline);
    parProps.SmallCaps = PropertyAssignHelper.TryAssign(props.SmallCaps, parProps.SmallCaps);
    parProps.StrikeThrough = PropertyAssignHelper.TryAssign(props.Strike, parProps.StrikeThrough);
  }

  public void FillRunProperties(DocxDocument.Model.RunProperties parProps, DocumentFormat.OpenXml.Wordprocessing.RunProperties props)
  {
    parProps.Bold = PropertyAssignHelper.TryAssign(props.Bold, parProps.Bold);
    parProps.AllCaps = PropertyAssignHelper.TryAssign(props.Caps, parProps.AllCaps);
    parProps.DoubleStrikeThrough = PropertyAssignHelper.TryAssign(props.DoubleStrike, parProps.DoubleStrikeThrough);
    parProps.Italic = PropertyAssignHelper.TryAssign(props.Italic, parProps.Italic);
    parProps.Underline = PropertyAssignHelper.TryAssign(props.Underline, parProps.Underline);
    parProps.SmallCaps = PropertyAssignHelper.TryAssign(props.SmallCaps, parProps.SmallCaps);
    parProps.StrikeThrough = PropertyAssignHelper.TryAssign(props.Strike, parProps.StrikeThrough);
  }
}