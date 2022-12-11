namespace DocumentModel.Math;

/// <summary>
/// Subscript Function.
/// </summary>
public class SubscriptImpl: ModelElementImpl, Subscript
{
  public DocumentFormat.OpenXml.Math.Subscript? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Subscript?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SubscriptImpl(): base() {}
  
  public SubscriptImpl(DocumentFormat.OpenXml.Math.Subscript openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Subscript Properties.
  /// </summary>
  public SubscriptProperties? SubscriptProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Subscript (Subscript function).
  /// </summary>
  public SubArgument? SubArgument
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
