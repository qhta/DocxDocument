namespace DocumentModel.Wordprocessing;

public interface IFootnoteProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IFootnotePosition? FootnotePosition { get ; set; }

  public DocumentModel.Wordprocessing.INumberingFormat? NumberingFormat { get ; set; }

  public INumberingStart? NumberingStart { get ; set; }

  public INumberingRestart? NumberingRestart { get ; set; }

}
