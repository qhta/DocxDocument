namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SharpenSoften Class.
/// </summary>
public class SharpenSoften: ModelElement
{
  /// <summary>
  ///   amount, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Amount { get; set; }
}