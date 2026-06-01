namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the Statistics Class.
/// </summary>
public class Statistics: ModelElement
{
  /// <summary>
  ///   quartileMethod, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public QuartileMethod? QuartileMethod { get; set; }
}
