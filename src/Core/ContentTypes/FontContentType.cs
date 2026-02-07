namespace Hamfer.WebApi.Core.ContentTypes;

// Font/typeface data.
// https://www.iana.org/assignments/media-types/media-types.xhtml#font
// To use csv: ^([^,]+),(font/[a-z0-9+-_]+),(.+)$	=>	\t"$1": "$2",\t\t// '$1' from reference $3
// last updated as 2025-12-25
public static class FontContentType
{
	public static readonly Dictionary<string, string> ContentTypes = new()
	{
    {"collection", "font/collection"},		// 'collection' from reference [RFC8081]
    {"otf", "font/otf"},		// 'otf' from reference [RFC8081]
    {"sfnt", "font/sfnt"},		// 'sfnt' from reference [RFC8081]
    {"ttf", "font/ttf"},		// 'ttf' from reference [RFC8081]
    {"woff", "font/woff"},		// 'woff' from reference [RFC8081]
    {"woff2", "font/woff2"},		// 'woff2' from reference [RFC8081]
	};
}