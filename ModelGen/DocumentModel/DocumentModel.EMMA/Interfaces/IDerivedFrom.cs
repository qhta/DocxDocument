namespace DocumentModel.EMMA;

/// <summary>
/// Defines the DerivedFrom Class.
/// </summary>
public interface IDerivedFrom // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// resource
  /// </summary>
  public System.String? Resource { get ; set; }
  
  /// <summary>
  /// composite
  /// </summary>
  public System.Boolean? Composite { get ; set; }
  
}
