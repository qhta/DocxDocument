namespace DocumentModel;

public static class ModeElementUtils
{
    /// <summary>
  ///   Perform a deep copy of the object properties.
  /// </summary>
  /// <typeparam name="T">The type of object being copied.</typeparam>
  /// <param name="source">The object instance to copy.</param>
  /// <returns>The copied object.</returns>
  [DebuggerStepThrough]
  public static T? CopyDeep<T>(this T source, Qhta.Xml.IXmlSerializer serializer)
  {
    // Don't serialize a null object, simply return the default for that object
    if (ReferenceEquals(source, null)) return default;
#pragma warning disable SYSLIB0011
    Stream stream = new MemoryStream();
    using (stream)
    {
      serializer.Serialize(stream, source);
      stream.Seek(0, SeekOrigin.Begin);
      return (T?)serializer.Deserialize(stream);
    }
  }
}
