namespace DocumentModel.Presentation;

/// <summary>
/// Attribute Name List.
/// </summary>
public interface IAttributeNameList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<String>? AttributeNames { get ; set; }
  
}
