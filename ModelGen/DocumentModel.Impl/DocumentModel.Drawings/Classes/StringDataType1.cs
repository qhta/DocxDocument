namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StringDataType Class.
/// </summary>
public class StringDataType1Impl: ModelElementImpl, StringDataType1
{
  public DocumentFormat.OpenXml.Drawing.Charts.StringDataType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StringDataType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// PointCount.
  /// </summary>
  public virtual UInt32? PointCount
  {
    get;
    set;
  }
  
}
