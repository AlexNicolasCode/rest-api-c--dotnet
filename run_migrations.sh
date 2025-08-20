#!/bin/bash
set -e

if [ -z "$1" ]; then
  echo "Error: DB_URL environment variable is not set."
  exit 1
fi

echo "Running dotnet ef database update with connection: $1"
dotnet ef database update --project "./API" --connection "$1"
