namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the BackgroundProperties Class.
/// </summary>
public class BackgroundProperties: ModelElement
{
  /// <summary>
  ///   bwMode, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public BlackWhiteMode? Mode { get; set; }

  /// <summary>
  ///   bwPure, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public BlackWhiteMode? Pure { get; set; }

  /// <summary>
  ///   bwNormal, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public BlackWhiteMode? Normal { get; set; }

  /// <summary>
  ///   targetScreenSize, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public TargetScreenSize? TargetScreenSize { get; set; }
}
