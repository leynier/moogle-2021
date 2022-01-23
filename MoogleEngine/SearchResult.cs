namespace MoogleEngine;

public class SearchResult
{
    private SearchItem[] items;

    public SearchResult(SearchItem[] items, string suggestion = "")
    {
        if (items == null)
        {
            throw new ArgumentNullException("items");
        }

        this.items = items;
        Suggestion = suggestion;
    }

    public SearchResult() : this(new SearchItem[0]) { }

    public string Suggestion { get; private set; }

    public IEnumerable<SearchItem> Items() => this.items;

    public int Count => this.items.Length;
}
