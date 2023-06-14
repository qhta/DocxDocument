namespace ModelGen;

/// <summary>
/// Member Status Selector
/// </summary>
[Flags]
public enum MSS
{
  Any = 0,
  Accepted      = 0x01,
  Rejected      = 0x02,
  Used          = 0x04,
  Unused        = 0x08,
  Valid         = 0x10,
  Invalid       = 0x20,
  Converted   = 0x40,
  ConvertedTo = 0x80,
}