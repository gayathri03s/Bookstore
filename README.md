# Bookstore

Simple Book Service
Reading Corp needs a new IT application to deal with the large number of books. We don’t ask you
to create an entire library service but just a basic structure to maintain a catalogue of books. Please
find the requirements listed below:
 The solution should capture the following information
o Book id
o Book name
o Author
o Registration timestamp
o Category (thriller, history, drama or biography)
o Description
 Implementation of one Web API method for clients to POST a new book. The URL to POST
the new book should use the pattern api/book/create and the method should return the
new book id back to the client.
 Implementation of one Web API method for clients to PUT (update) an existing book. The
URL to update the existing book should use the pattern api/book/{bookId}/update and the
method should return the entire book structure back to the client.
Partial updates should be possible as the client may want to update some book fields but
not all of them in the same PUT request.
 Implementation of simple client application that will allow http interaction with the two
Web API methods described below. Could be as simple as a console application although a
basic HTML and JS application would be also a good option.
 The books should be persisted in any structure that is not a text file.

The solution should be
 Implemented the exercise in one single Visual Studio solution (2022 Community Edition can
be downloaded and used for free).
 Implemented using ASP.NET or ASP.NET Core Web API.
 Data should be persisted in any structure that is not a text file.
 The source code should be available on GitHub.com for review.

Feel free to use any sources you can find to help and extra credits for highlighting each source used
and why. However please try to avoid making heavy use of code generators or scaffolding.
We want to clearly see an understanding of the concepts and technologies plus develop a picture of
the developer’s coding skills. Auto generated code can make that difficult.
