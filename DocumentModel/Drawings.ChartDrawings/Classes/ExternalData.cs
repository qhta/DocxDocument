namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ExternalData Class.
/// </summary>
public class ExternalData: ModelElement
{
  /// <summary>
  ///   RelId of the relationship for the external data, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   True if the external link should automatically update, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? AutoUpdate { get; set; }
}