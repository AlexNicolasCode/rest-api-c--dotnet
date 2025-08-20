run:
	dotnet run --project=./API

run-migrations:
	dotnet ef database update

add-migration:
	dotnet ef migrations add $(NAME)
