namespace DocumentModel.Math;

/// <summary>
/// Defines the OfficeMathArgumentType Class.
/// </summary>
public class OfficeMathArgumentTypeImpl: ModelElementImpl, OfficeMathArgumentType
{
  public DocumentFormat.OpenXml.Math.OfficeMathArgumentType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.OfficeMathArgumentType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OfficeMathArgumentTypeImpl(): base() {}
  
  public OfficeMathArgumentTypeImpl(DocumentFormat.OpenXml.Math.OfficeMathArgumentType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Argument Properties.
  /// </summary>
  public virtual DocumentModel.Math.ArgumentProperties? ArgumentProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
