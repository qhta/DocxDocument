namespace DocumentModel.Office2013.Drawing.ChartStyle;

public interface IFontReference // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public FontCollectionIndex? Index { get ; set; }

  public List<string>? Modifiers { get ; set; }

}
