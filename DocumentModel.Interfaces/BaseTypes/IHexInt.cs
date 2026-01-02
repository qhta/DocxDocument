namespace DocumentModel;
/// <summary>
/// Defines a hexadecimal binary string that can be converted to and from various integer types.
/// </summary>
public interface IHexInt : IHexBinary
{
  /// <summary>
  /// Converts the current value to an 8-bit unsigned integer.
  /// </summary>
  /// <returns>An 8-bit unsigned integer that represents the converted value of the current instance.</returns>
  public byte ToByte();
  /// <summary>
  /// Gets the value from the specified 8-bit unsigned integer.
  /// </summary>
  /// <param name="val"></param>
  public void FromByte(byte val);
  /// <summary>
  /// Converts the specified hexadecimal binary value to its equivalent 16-bit unsigned integer.
  /// </summary>
  /// <returns></returns>
  public ushort ToUInt16();
  /// <summary>
  /// Gets the value from the specified 16-bit unsigned integer.
  /// </summary>
  public void FromUInt16(ushort val);

  /// <summary>
  /// Converts the specified hexadecimal binary value to its equivalent 32-bit signed integer.
  /// </summary>
  /// <returns></returns>
  public int ToInt();
  /// <summary>
  /// Gets the value from the specified 32-bit signed integer.
  /// </summary>
  /// <param name="val"></param>
  public void FromInt(int val);
  /// <summary>
  /// Converts the current value to its 32-bit unsigned integer representation.
  /// </summary>
  /// <returns>A 32-bit unsigned integer equivalent to the current value.</returns>
  public uint ToUInt();

  /// <summary>
  /// Gets the value from the specified 32-bit unsigned integer.
  /// </summary>
  /// <param name="val"></param>
  public void FromUInt(uint val);
}