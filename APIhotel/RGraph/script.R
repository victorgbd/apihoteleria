require(httr)
require(jsonlite)



get_user <- try(await(GET("http://localhost:51612/api/values")))
get_error(get_user)
#get_user_txt <- content(get_user)
#get_user_txt
#get_user_json <- fromJSON(get_user_txt, flatten = TRUE)
#get_user_df <- as.data.frame(get_user_txt)
#View(get_user_df)

#get_user_txt[[1]]
plot(list(1, 4, 5), list(1, 2, 3), "b")