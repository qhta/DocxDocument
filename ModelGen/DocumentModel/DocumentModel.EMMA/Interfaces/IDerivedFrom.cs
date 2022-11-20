namespace DocumentModel.EMMA;

/// <summary>
/// Defines the DerivedFrom Class.
/// </summary>
public interface IDerivedFrom // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// resource
  /// </summary>
  public string? Resource { get ; set; }
  
  /// <summary>
  /// composite
  /// </summary>
  public bool? Composite { get ; set; }
  
}
