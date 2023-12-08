import { ObjectType, Field, ID } from 'type-graphql';

@ObjectType()
export class ArtistSchema {
  @Field(() => ID)
  id!: string;

  @Field()
  fullName!: string;

  @Field()
  pseudoName!: string;

  @Field()
  country!: string;

  @Field(()=>[SongSchema])
  songs!: SongSchema[];
}

@ObjectType()
export class SongSchema {
  @Field(() => ID)
  id!: string;

  @Field()
  title!: string;

  @Field()
  year!: number;

  @Field()
  duration!: number;

  @Field()
  author!: ArtistSchema;
}
