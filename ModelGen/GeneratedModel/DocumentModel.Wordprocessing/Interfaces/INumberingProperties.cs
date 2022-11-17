namespace DocumentModel.Wordprocessing;

public interface INumberingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public INumberingLevelReference? NumberingLevelReference { get ; set; }

  public INumberingId? NumberingId { get ; set; }

  public INumberingChange? NumberingChange { get ; set; }

  public IInserted? Inserted { get ; set; }

}
