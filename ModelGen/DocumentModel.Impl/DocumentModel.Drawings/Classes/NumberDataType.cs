namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumberDataType Class.
/// </summary>
public class NumberDataTypeImpl: ModelElementImpl, NumberDataType
{
  public DocumentFormat.OpenXml.Drawing.Charts.NumberDataType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumberDataType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Format Code.
  /// </summary>
  public virtual String? FormatCode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Point Count.
  /// </summary>
  public virtual UInt32? PointCount
  {
    get;
    set;
  }
  
}
