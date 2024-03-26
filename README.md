# Announcements
Proje dizinine gidin ve aşağıdaki komutu çalıştırın.
'docker-compose up mssql' =>> Eğer kendi mssql serverınız var ise appsetting dosyalarında, connection stringleri değiştirin. 
Daha sonra Migration işlemi için, 'Announcement.DbMigrator' projesini çalıştırın veya 'Update-Database' komutunu çalıştırın.
Announcement.HttpApi.Host projesini çalıştırın. Swagger üzerinde end-pointleri görebilirsiniz. Ayrıca backgroundjobları hangfire dashbord üzerinden kontrol edebilirsiniz.
