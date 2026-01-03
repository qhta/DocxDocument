namespace DocumentModel;

/// <summary>
/// Stream data with versioning stored in variant.
/// </summary>
public interface IVStreamData : IEquatable<IVStreamData>
{
  /// <summary>
  /// Version of the stream data.
  /// </summary>
  public Guid? Version { get; set; }
  /// <summary>
  /// Gets or sets the binary data associated with this instance.
  /// </summary>
  public byte[] Data { get; set; }

}