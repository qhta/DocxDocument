namespace DocumentModel.Drawing.Diagrams;

public interface IDataModel // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IPointList? PointList { get ; set; }

  public IConnectionList? ConnectionList { get ; set; }

  public DocumentModel.Drawing.Diagrams.IBackground? Background { get ; set; }

  public IWhole? Whole { get ; set; }

  public IDataModelExtensionList? DataModelExtensionList { get ; set; }

}
