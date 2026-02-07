namespace Hamfer.WebApi.Core.ContentTypes;

// https://www.iana.org/assignments/media-types/media-types.xhtml#haptics
// To use csv: ^([^,]+),(haptics/[a-z0-9+-_]+),(.+)$	=>	\t"$1": "$2",\t\t// '$1' from reference $3
// last updated as 2025-12-25
public static class HapticsContentType
{
	public static readonly Dictionary<string, string> ContentTypes = new()
	{
		{"ivs", "haptics/ivs"},		// 'ivs' from reference [RFC9695]
		{"hjif", "haptics/hjif"},		// 'hjif' from reference [RFC9695]
		{"hmpg", "haptics/hmpg"},		// 'hmpg' from reference [RFC9695]
	};
}