namespace DocumentModel.CustomXml;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
public interface ISchemaLibrary // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISchema>? Schemas { get ; set; }
  
}
