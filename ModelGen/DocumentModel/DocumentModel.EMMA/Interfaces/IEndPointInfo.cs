namespace DocumentModel.EMMA;

/// <summary>
/// Defines the EndPointInfo Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.EMMA.IEndPoint))]
public interface IEndPointInfo // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
}
