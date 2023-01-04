import React from 'react';

export interface IPageProps<T> {
  controller: T;
}

export function page<T extends object>(Component: React.ComponentType<T>) {
  // eslint-disable-next-line react/display-name
  return ({ controller }: IPageProps<T>) => {
    return <Component {...controller} />;
  };
}
