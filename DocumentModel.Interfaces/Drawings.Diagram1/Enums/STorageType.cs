namespace DocumentModel.Drawings.Diagram1;

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