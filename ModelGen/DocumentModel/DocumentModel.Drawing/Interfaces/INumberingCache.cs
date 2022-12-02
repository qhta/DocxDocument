namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumberingCache Class.
/// </summary>
public interface INumberingCache // : DocumentModel.Drawing.INumberDataType
{
  public System.String? FormatCode { get ; set; }
  
  public System.UInt32? PointCount { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.INumericPoint>? NumericPoints { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
