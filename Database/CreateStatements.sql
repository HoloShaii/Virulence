 -- BigDouble has arbitrary size, therefore text is used for numerical values that use BigDouble
DROP TABLE IF EXISTS "player" CASCADE;
DROP TABLE IF EXISTS "world" CASCADE;
DROP TABLE IF EXISTS "playerscavengers" CASCADE;
DROP TABLE IF EXISTS "scavengers" CASCADE;
DROP TABLE IF EXISTS "worldtiles" CASCADE;
DROP TABLE IF EXISTS "tile" CASCADE;

CREATE TABLE player (
	id					SERIAL,
	saveName			varchar(255),
	worldId				int,
	funds				text,
	humans				text,
	PRIMARY KEY(id, saveName)
);

CREATE TABLE playerScavengers (
	playerId			int,
	scavengerId			int,
	PRIMARY KEY(playerId, scavengerId)
);

CREATE TABLE scavengers (
	id					SERIAL PRIMARY KEY,
	name				varchar(255),
	age					text,
	lifeSpan			text,
	efficiencyMulti		text,
	fundsPerGameTick	text,
	location			point
);

CREATE TABLE world (
	id					SERIAL PRIMARY KEY
);

CREATE TABLE worldTiles (
	worldId				int,
	tileId				int,
	PRIMARY KEY(worldId, tileId)
);

CREATE TABLE tile (
	id					SERIAL PRIMARY KEY,
	infection			text,
	location			point
);


