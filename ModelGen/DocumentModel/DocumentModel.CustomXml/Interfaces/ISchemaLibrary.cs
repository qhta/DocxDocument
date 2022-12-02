namespace DocumentModel.CustomXml;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
public interface ISchemaLibrary // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.CustomXml.ISchema>? Schemas { get ; set; }
  
}
