namespace DocumentModel.Wordprocessing;

public interface IDocPartProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IDocPartName? DocPartName { get ; set; }

  public IStyleId? StyleId { get ; set; }

  public DocumentModel.Wordprocessing.ICategory? Category { get ; set; }

  public IDocPartTypes? DocPartTypes { get ; set; }

  public IBehaviors? Behaviors { get ; set; }

  public DocumentModel.Wordprocessing.IDescription? Description { get ; set; }

  public IDocPartId? DocPartId { get ; set; }

}
