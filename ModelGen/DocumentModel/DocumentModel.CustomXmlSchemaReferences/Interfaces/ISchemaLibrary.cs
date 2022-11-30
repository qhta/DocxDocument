namespace DocumentModel.CustomXmlSchemaReferences;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
public interface ISchemaLibrary // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.CustomXmlSchemaReferences.ISchema>? Schemas { get ; set; }
  
}
