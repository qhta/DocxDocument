namespace DocumentModel.Drawings.Diagram1;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the STorageType enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum STorageType
{
  /// <summary>
  ///   sibTrans.
  /// </summary>
  SibTrans,

  /// <summary>
  ///   parTrans.
  /// </summary>
  ParTrans
}