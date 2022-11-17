namespace DocumentModel.Wordprocessing;

public interface IEndnoteProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IEndnotePosition? EndnotePosition { get ; set; }

  public DocumentModel.Wordprocessing.INumberingFormat? NumberingFormat { get ; set; }

  public INumberingStart? NumberingStart { get ; set; }

  public INumberingRestart? NumberingRestart { get ; set; }

}
