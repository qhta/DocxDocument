namespace DocumentModel.Wordprocessing;

public interface IParagraphMarkRunProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IInserted? Inserted { get ; set; }

  public IDeleted? Deleted { get ; set; }

  public IMoveFrom? MoveFrom { get ; set; }

  public DocumentModel.Wordprocessing.IMoveTo? MoveTo { get ; set; }

}
