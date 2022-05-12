
select *from FootballLeague;

create table FootballLeague(
MatchId int primary key,
TeamName1 varchar(50),
TeamName2 varchar(50),
Status varchar(50),
WinningTeam varchar(50),
Points int
);


Insert into FootballLeague
Values(1001,'Italy','France','Win','France',4);
Insert into FootballLeague
Values(1002,'Brazil','Portugal','Draw',null,2);
Insert into FootballLeague
Values(1003,'England','Japan','Win','England',4);
Insert into FootballLeague
Values(1004,'USA','Russia','Win','Russia',4);
Insert into FootballLeague
Values(1005,'Portugal','Italy','Draw',null,2);
Insert into FootballLeague
Values(1006,'Brazil','France','Win','Brazil',4);
Insert into FootballLeague
Values(1007,'England','Russia','Win','Russia',4);
Insert into FootballLeague
Values(1008,'Japan','USA','Draw',null,2);

Create procedure SpFootballLeague
@MatchId int,
@TeamName1 varchar(50),
@TeamName2 varchar(50),
@Status varchar(50),
@WinningTeam varchar(50),
@Points int
as 
begin
Insert into FootballLeague
Values(@MatchId, @TeamName1, @TeamName2, @Status, @WinningTeam, @Points)
end


CREATE VIEW Match_View AS
SELECT TeamName1, TeamName2
FROM FootballLeague
WHERE Status = 'Draw';

Select * from Match_View