run:
	dotnet watch run

run-migrations:
	dotnet ef database update

add-migration:
	dotnet ef migrations add $(NAME)
