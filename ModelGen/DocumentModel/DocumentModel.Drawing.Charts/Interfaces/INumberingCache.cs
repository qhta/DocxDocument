namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the NumberingCache Class.
/// </summary>
public interface INumberingCache // : DocumentModel.Drawing.Charts.INumberDataType
{
  public System.String? FormatCode { get ; set; }
  
  public System.UInt32? PointCount { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.INumericPoint>? NumericPoints { get ; set; }
  
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
