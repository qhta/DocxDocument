namespace DocumentModel.Presentation;

public interface ITiming // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ITimeNodeList? TimeNodeList { get ; set; }

  public IBuildList? BuildList { get ; set; }

  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }

}
