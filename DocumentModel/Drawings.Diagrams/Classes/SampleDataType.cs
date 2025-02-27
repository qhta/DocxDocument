namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SampleDataType Class.
/// </summary>
public class SampleDataType: ModelElement
{
  /// <summary>
  ///   Use Default
  /// </summary>
  public bool? UseDefault { get; set; }

  /// <summary>
  ///   Data Model.
  /// </summary>
  public DataModel? DataModel { get; set; }
}