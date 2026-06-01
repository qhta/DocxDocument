namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ExternalData Class.
/// </summary>
public class ExternalData: ModelElement
{
  /// <summary>
  ///   RelId of the relationship Ifor the external data, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   True if the external link should automatically update, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public bool? AutoUpdate { get; set; }
}
