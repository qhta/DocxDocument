namespace DocumentModel.Office2016.Drawing;

/// <summary>
/// Defines the CreationId Class.
/// </summary>
public interface ICreationId // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Id { get ; set; }
  
}
