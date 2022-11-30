namespace DocumentModel;

/// <summary>
/// Represents a base class for all root elements.
/// </summary>
public interface IOpenXmlPartRootElement // : DocumentModel.IOpenXmlCompositeElement
{
  /// <summary>
  /// Gets a value indicating whether the Save method will try write all namespace declaration on the root element.
  /// </summary>
  public System.Boolean? WriteAllNamespaceOnRoot { get ; set; }
  
}
