namespace DocumentModel.Math;

/// <summary>
/// Sub-Superscript Function.
/// </summary>
public class SubSuperscriptImpl: ModelElementImpl, SubSuperscript
{
  public DocumentFormat.OpenXml.Math.SubSuperscript? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.SubSuperscript?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SubSuperscriptImpl(): base() {}
  
  public SubSuperscriptImpl(DocumentFormat.OpenXml.Math.SubSuperscript openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Sub-Superscript Properties.
  /// </summary>
  public SubSuperscriptProperties? SubSuperscriptProperties
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
  /// Subscript (Sub-Superscript).
  /// </summary>
  public SubArgument? SubArgument
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Superscript (Sub-Superscript function).
  /// </summary>
  public SuperArgument? SuperArgument
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
