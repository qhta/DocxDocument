namespace DocumentModel.Math;

/// <summary>
/// Superscript Function.
/// </summary>
public class SuperscriptImpl: ModelElementImpl, Superscript
{
  public DocumentFormat.OpenXml.Math.Superscript? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Superscript?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SuperscriptImpl(): base() {}
  
  public SuperscriptImpl(DocumentFormat.OpenXml.Math.Superscript openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Superscript Properties.
  /// </summary>
  public SuperscriptProperties? SuperscriptProperties
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
  /// Superscript (Superscript function).
  /// </summary>
  public SuperArgument? SuperArgument
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
