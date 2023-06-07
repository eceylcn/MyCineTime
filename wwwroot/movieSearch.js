$(document).ready(function () {
    // Target the search input and listen for keyup event
    $('#searchString').keyup(function () {
        var searchString = $(this).val();

        // Send an AJAX request to the server to get movie name suggestions
        $.ajax({
            url: '/Movies/SearchMovies',
            method: 'GET',
            data: { searchString: searchString },
            success: function (response) {
                // Clear the existing suggestions
                $('#movieSuggestions').empty();

                // Add the new suggestions to the dropdown
                response.forEach(function (movie) {
                    $('#movieSuggestions').append('<a class="dropdown-item" href="#">' + movie + '</a>');
                });

                // Show or hide the dropdown based on the number of suggestions
                if (response.length > 0) {
                    $('#movieSuggestionsDropdown').show();
                } else {
                    $('#movieSuggestionsDropdown').hide();
                }
            },
            error: function (error) {
                console.log(error);
            }
        });
    });
});
