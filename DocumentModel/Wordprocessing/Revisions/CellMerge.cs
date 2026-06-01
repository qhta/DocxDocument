namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Vertically Merged/Split ITable ICells.
/// </summary>
public class CellMerge: ModelElement
{
  /// <summary>
  ///   vMerge
  /// </summary>
  public VerticalMergeRevisionKind? VerticalMerge { get; set; }

  /// <summary>
  ///   vMergeOrig
  /// </summary>
  public VerticalMergeRevisionKind? VerticalMergeOriginal { get; set; }

  /// <summary>
  ///   author
  /// </summary>
  public string? Author { get; set; }

  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public string? Id { get; set; }
}
