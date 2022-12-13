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
  public DocumentModel.Math.SuperscriptProperties? SuperscriptProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Superscript (Superscript function).
  /// </summary>
  public DocumentModel.Math.SuperArgument? SuperArgument
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
