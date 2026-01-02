namespace DocumentModel;
/// <summary>
/// Value represented as Base64 binary string which can be converted to and from byte array.
/// </summary>
public interface IBase64Binary : IEquatable<IBase64Binary>
{
  /// <summary>
  /// Converts Base64Binary to string representation.
  /// </summary>
  /// <returns>A string containing the Base64 representation of the value.</returns>
  public string ToString();
  /// <summary>
  /// Gets the value from the specified Base64Binary string representation.
  /// </summary>
  /// <param name="val">A string containing the Base64 representation of the value.</param>
  public void FromString(string val);
  /// <summary>
  /// Converts string to corresponding byte array.
  /// </summary>
  /// <returns>A byte array containing the binary data represented by the Base64 value.</returns>
  public byte[] ToBytes();
  /// <summary>
  /// Gets the value from the specified byte array.
  /// </summary>
  /// <param name="val">A byte array containing the binary data represented by the Base64 value.</param>
  public void FromBytes(byte[] val);
}