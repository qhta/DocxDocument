namespace DocumentModel.EMMA;

/// <summary>
/// Defines the DerivedFrom Class.
/// </summary>
public interface IDerivedFrom // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// resource
  /// </summary>
  public String? Resource { get ; set; }
  
  /// <summary>
  /// composite
  /// </summary>
  public Boolean? Composite { get ; set; }
  
}
