namespace DocumentModel;
/// <summary>
/// Value represented as hexadecimal binary string which can be converted to and from byte array.
/// </summary>
public interface IHexBinary: IEquatable<IHexBinary>
{
  /// <summary>
  /// Number of bytes in the value.
  /// </summary>
  public int Length { get; }
  /// <summary>
  /// Converts the specified hexadecimal binary value to its equivalent string representation.
  /// </summary>
  /// <returns>A string containing the hexadecimal representation of the value.</returns>
  public string ToString();
  /// <summary>
  /// Gets the value from the specified string representation.
  /// </summary>
  /// <param name="val">A string containing the hexadecimal representation of the value.</param>
  public void FromString(string val);
  /// <summary>
  /// Converts the specified hexadecimal binary value to its equivalent byte array representation.
  /// </summary>
  /// <returns>A byte array containing the binary data represented by the specified hexadecimal value.</returns>
  public byte[] ToBytes();
  /// <summary>
  /// Get the value from the specified byte array representation.
  /// </summary>
  /// <param name="val"></param>
  public void FromBytes(byte[] val);
}